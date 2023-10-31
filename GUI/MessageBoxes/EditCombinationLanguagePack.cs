using SceenshotTextRecognizer.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class EditCombinationLanguagePack : Form
    {
        public EditCombinationLanguagePack()
        {
            InitializeComponent();

            Text = "Создание новой комбинация";
            _dontUse = Model.Downloaded;

            UpdateForm();
        }
        public EditCombinationLanguagePack(CombinationLanguagePacks combinationLanguagePacks)
        {
            InitializeComponent();

            _name = combinationLanguagePacks.name;
            _editCombination = true;

            textBoxName.Text = combinationLanguagePacks.name;
            foreach (Model model in Model.models)
            {
                if (combinationLanguagePacks.models.Find(item => item == model.model) != null)
                    _use.Add(model);
                else _dontUse.Add(model);
            }

            UpdateForm();
        }

        private string _name;
        private bool _editCombination;

        List<Model> _use = new List<Model>();
        List<Model> _dontUse = new List<Model>();

        private bool _dontSave;

        #region lists

        private void listViewDontUseModels_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDontUseModels.SelectedItems.Count != 1)
                return;

            _dontSave = true;

            Model model = _dontUse.Find(item => item.name == listViewDontUseModels.SelectedItems[0].Text);
            _use.Add(model);
            _dontUse.Remove(model);

            UpdateForm();
        }


        private void listViewUseModels_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUseModels.SelectedItems.Count != 1)
                return;

            _dontSave = true;

            Model model = _use.Find(item => item.name == listViewUseModels.SelectedItems[0].Text);
            _dontUse.Add(model);
            _use.Remove(model);

            UpdateForm();
        }

        #endregion

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            _dontSave = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите имя комбинации языковх пекетов", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (listViewUseModels.Items.Count < 2)
            {
                MessageBox.Show("Выберите хотябы два языковых пекета", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> stringModels = new List<string>();
            foreach (Model model in _use)
                stringModels.Add(model.model);

            if (_editCombination)
            {
                int index = CombinationLanguagePacks.combinationLanguagePacks.FindIndex(item => item.name == _name);
                CombinationLanguagePacks.combinationLanguagePacks[index] = new CombinationLanguagePacks(textBoxName.Text, stringModels);
                CombinationLanguagePacks.Save();
            }
            else
            {
                CombinationLanguagePacks.combinationLanguagePacks.Add(new CombinationLanguagePacks(textBoxName.Text, stringModels));
                CombinationLanguagePacks.Save();

                _editCombination = true;
                _name = CombinationLanguagePacks.combinationLanguagePacks[CombinationLanguagePacks.combinationLanguagePacks.Count - 1].name;
            }

            _dontSave = false;
            UpdateForm();

            MessageBox.Show($"Языковая комбинация \"{textBoxName.Text}\" сохранена.", "Сохранине языковой комбинации", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateForm()
        {
            listViewUseModels.Clear();
            listViewDontUseModels.Clear();

            foreach (Model model in _use)
                listViewUseModels.Items.Add(model.name);
            foreach (Model model in _dontUse)
                listViewDontUseModels.Items.Add(model.name);

            if (_editCombination)
            {
                if (_dontSave) Text = $"Языкованя комбинация \"{_name}\"*";
                else Text = $"Языкованя комбинация \"{_name}\"";
            }
            else Text = $"Создание новой комбинации";
        }
    }
}
