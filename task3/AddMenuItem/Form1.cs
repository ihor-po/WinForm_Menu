using System;
using System.Windows.Forms;

namespace AddMenuItem
{
    public partial class cmi_form : Form
    {
        int n;
        ToolStripMenuItem item;

        public cmi_form()
        {
            item = null; //объект текущего пукта меню
            n = -1; //индекс текущего пункта меню
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            cmi_b_createItem.Click += Cmi_b_createItem_Click;
            cmi_b_createSubItem.Click += Cmi_b_createSubItem_Click;
            cmi_cb_menuItems.SelectedIndexChanged += Cmi_cb_menuItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Обработка изменения выбранного элемента в combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmi_cb_menuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem _item in mci_menu.Items)
            {
                if (_item.Text == cmi_cb_menuItems.SelectedItem.ToString())
                {
                    item = _item;
                    break;
                }
            }
        }

        /// <summary>
        /// Создание под-пункта меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmi_b_createSubItem_Click(object sender, EventArgs e)
        {
            if (item == null && cmi_cb_menuItems.Items.Count == 0)
            {
                MessageBox.Show("Вы не можете добавлять под пункты!\rДобавте - пункты )", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmi_tb_subItem.Text.Length > 0)
                {
                    if (item == null)
                    {
                        foreach (ToolStripMenuItem _item in mci_menu.Items)
                        {
                            if (_item.Text == cmi_cb_menuItems.SelectedItem.ToString())
                            {
                                item = _item;
                                break;
                            }
                        }
                    }

                    if (GetSubMenuItemIndex(cmi_tb_subItem.Text, item) == -1)
                    {
                        item.DropDownItems.Add(cmi_tb_subItem.Text);
                        cmi_tb_subItem.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Такой под-пункт меню уже существует!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите назване под-пункта меню", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Создание пункта меню верхнего уровня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmi_b_createItem_Click(object sender, EventArgs e)
        {
            if (cmi_tb_topItem.Text.Length > 0)
            {
                item = new ToolStripMenuItem(cmi_tb_topItem.Text);

                if (GetMenuItemIndex(item.Text) == -1)
                {
                    mci_menu.Items.Add(item);
                    cmi_cb_menuItems.Items.Add(cmi_tb_topItem.Text); //добавление в комбо бокс нового пункта меню
                    cmi_cb_menuItems.SelectedIndex = GetCBIndex(cmi_tb_topItem.Text); //выбор нового названия в комбобоксе
                    cmi_tb_topItem.Text = "";
                }
                else
                {
                    item = null;
                    MessageBox.Show("Такой пункт меню уже существует!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите назване пункта меню", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Получение индекса из меню верхнего уровня
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private int GetMenuItemIndex(string title)
        {
            int n = 0;
            foreach (ToolStripMenuItem item in mci_menu.Items)
            {
                if (item.Text == title)
                {
                    return n;
                }
                n++;
            }
            return -1;
        }

        /// <summary>
        /// Получение индекса среди понпуктов выбранного меню
        /// </summary>
        /// <param name="title"></param>
        /// <param name="_topLevel"></param>
        /// <returns></returns>
        private int GetSubMenuItemIndex(string title, ToolStripMenuItem _topLevel)
        {
            int n = 0;
            foreach (ToolStripMenuItem item in _topLevel.DropDownItems)
            {
                
                if (item.Text == title)
                {
                    return n;
                }
                n++;
            }
            return -1;
        }

        /// <summary>
        /// Получение индекса в котейнере комбо бокса
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private int GetCBIndex(string title)
        {
            int n = 0;
            foreach (string item in cmi_cb_menuItems.Items)
            {
                if (item == title)
                {
                    return n;
                }
                n++;
            }
            return -1;
        }
    }
}
