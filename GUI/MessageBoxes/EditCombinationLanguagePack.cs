using ReaLTaiizor.Child.Crown;
using SceenshotTextRecognizer.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class EditCombinationLanguagePack : Form
    {
        public EditCombinationLanguagePack()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            Text = "Создание новой комбинация";
            _dontUse = Model.Downloaded;

            UpdateForm();
        }
        public EditCombinationLanguagePack(CombinationLanguagePacks combinationLanguagePacks)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            _name = combinationLanguagePacks.name;
            _editCombination = true;

            hopeTextBoxName.Text = combinationLanguagePacks.name;
            foreach (Model model in Model.models)
            {
                if (combinationLanguagePacks.models.Find(item => item == model.model) != null)
                {
                    _use.Add(model);
                }
                else
                {
                    _dontUse.Add(model);
                }
            }

            UpdateForm();
        }

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
            Model model = _dontUse.Find(item => item.name == crownListViewDontUseModels.Items[crownListViewDontUseModels.SelectedIndices[0]].Text);

            _use.Add(model);
            _dontUse.Remove(model);

            _dontSave = true;
            UpdateForm();
        }

        private void hopeButtonRemove_Click(object sender, EventArgs e)
        {
            Model model = _use.Find(item => item.name == crownListViewUseModels.Items[crownListViewUseModels.SelectedIndices[0]].Text);

            _dontUse.Add(model);
            _use.Remove(model);

            _dontSave = true;
            UpdateForm();
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
                MessageBox.Show("Введите имя комбинации языковх пекетов", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (crownListViewUseModels.Items.Count < 2)
            {
                MessageBox.Show("Выберите хотябы два языковых пекета", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> stringModels = new List<string>();
            foreach (Model model in _use)
            {
                stringModels.Add(model.model);
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

            MessageBox.Show($"Языковая комбинация \"{hopeTextBoxName.Text}\" сохранена.", "Сохранине языковой комбинации", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateForm()
        {
            crownListViewUseModels.Items.Clear();
            crownListViewDontUseModels.Items.Clear();

            for (int i = 0; i != _use.Count; i++)
            {
                var crownListItem = new CrownListItem(_use[i].name);
                crownListViewUseModels.Items.Add(crownListItem);
            }

            for (int i = 0; i != _dontUse.Count; i++)
            {
                var crownListItem = new CrownListItem(_dontUse[i].name);
                crownListViewDontUseModels.Items.Add(crownListItem);
            }

            if (_editCombination)
            {
                if (_dontSave)
                {
                    hopeForm.Text = $"Языкованя комбинация \"{_name}\"*";
                    Text = $"Языкованя комбинация \"{_name}\"*";
                }
                else
                {
                    hopeForm.Text = $"Языкованя комбинация \"{_name}\"";
                    Text = $"Языкованя комбинация \"{_name}\"";
                }
            }
            else
            {
                hopeForm.Text = $"Создание новой комбинации";
                Text = $"Создание новой комбинации";
            }
        }
    }
}
