using ReaLTaiizor.Child.Crown;
using SceenshotTextRecognizer.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using SceenshotTextRecognizer.Properties;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class EditCombinationLanguagePack : Form
    {
        public EditCombinationLanguagePack(FormMain formMain)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            this.formMain = formMain;

            Text = "Создание новой комбинация";
            _dontUse = Model.Downloaded;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;

            UpdateForm();
        }
        public EditCombinationLanguagePack(CombinationLanguagePacks combinationLanguagePacks, FormMain formMain)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            this.formMain = formMain;

            _name = combinationLanguagePacks.name;
            _editCombination = true;

            hopeTextBoxName.Text = combinationLanguagePacks.name;
            foreach (Model model in Model.models)
            {
                if (combinationLanguagePacks.models.Find(item => item == model.Code) != null)
                {
                    _use.Add(model);
                }
                else
                {
                    _dontUse.Add(model);
                }
            }

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;

            UpdateForm();
        }

        private FormMain formMain;

        private string _name;
        private bool _editCombination;

        List<Model> _use = new List<Model>();
        List<Model> _dontUse = new List<Model>();

        private bool _dontSave;

        #region lists

        private void crownListViewUseModels_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (crownListViewUseModels.SelectedIndices.Count > 0)
            {
                hopeButtonRemove.Visible = true;
            }
            else
            {
                hopeButtonRemove.Visible = false;
            }
        }

        private void crownListViewDontUseModels_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (crownListViewDontUseModels.SelectedIndices.Count > 0)
            {
                hopeButtonAdd.Visible = true;
            }
            else
            {
                hopeButtonAdd.Visible = false;
            }
        }

        private void hopeButtonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void crownListViewDontUseModels_DoubleClick(object sender, EventArgs e)
        {
            if (crownListViewDontUseModels.SelectedIndices.Count == 0)
            {
                return;
            }

            Add();
        }

        private void hopeButtonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void crownListViewUseModels_DoubleClick(object sender, EventArgs e)
        {
            if (crownListViewUseModels.SelectedIndices.Count == 0)
            {
                return;
            }

            Remove();
        }

        #endregion

        private void hopeTextBoxName_TextChanged(object sender, EventArgs e)
        {
            _dontSave = true;
        }

        private void hopeButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hopeTextBoxName.Text))
            {
                MessageBox.Show("Введите имя языкой комбинации", "Имя крмбинации отсутствует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (crownListViewUseModels.Items.Count < 2)
            {
                MessageBox.Show("Выберите хотябы два языка", "Не выбраны языки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> stringModels = new List<string>();
            foreach (Model model in _use)
            {
                stringModels.Add(model.Code);
            }

            if (_editCombination)
            {
                int index = CombinationLanguagePacks.combinationLanguagePacks.FindIndex(item => item.name == _name);
                CombinationLanguagePacks.combinationLanguagePacks[index] = new CombinationLanguagePacks(hopeTextBoxName.Text, stringModels);
                CombinationLanguagePacks.Save();
            }
            else
            {
                CombinationLanguagePacks.combinationLanguagePacks.Add(new CombinationLanguagePacks(hopeTextBoxName.Text, stringModels));
                CombinationLanguagePacks.Save();

                _editCombination = true;
                _name = CombinationLanguagePacks.combinationLanguagePacks[CombinationLanguagePacks.combinationLanguagePacks.Count - 1].name;
            }

            _dontSave = false;
            UpdateForm();
            formMain.UpdateForm();

            MessageBox.Show($"Языковая комбинация \"{hopeTextBoxName.Text}\" сохранена.", "Сохранине", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add()
        {
            Model model = _dontUse.Find(item => item.Name == crownListViewDontUseModels.Items[crownListViewDontUseModels.SelectedIndices[0]].Text);

            _use.Add(model);
            _dontUse.Remove(model);

            _dontSave = true;
            UpdateForm();
        }

        private void Remove()
        {
            Model model = _use.Find(item => item.Name == crownListViewUseModels.Items[crownListViewUseModels.SelectedIndices[0]].Text);

            _dontUse.Add(model);
            _use.Remove(model);

            _dontSave = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            crownListViewUseModels.Items.Clear();
            crownListViewDontUseModels.Items.Clear();

            for (int i = 0; i != _use.Count; i++)
            {
                var crownListItem = new CrownListItem(_use[i].Name);
                crownListViewUseModels.Items.Add(crownListItem);
            }

            for (int i = 0; i != _dontUse.Count; i++)
            {
                var crownListItem = new CrownListItem(_dontUse[i].Name);
                crownListViewDontUseModels.Items.Add(crownListItem);
            }

            if (_editCombination)
            {
                if (_dontSave)
                {
                    hopeForm.Text = $"Языковая комбинация \"{_name}\"*";
                    Text = $"Языковая комбинация \"{_name}\"*";
                }
                else
                {
                    hopeForm.Text = $"Языковая комбинация \"{_name}\"";
                    Text = $"Языковая комбинация \"{_name}\"";
                }
            }
            else
            {
                hopeForm.Text = $"Создание новой комбинации";
                Text = $"Создание новой комбинации";
            }
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
