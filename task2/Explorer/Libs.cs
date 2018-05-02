using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    public class Libs
    {
        /// <summary>
        /// Получение списка дисков и создание узлов для TreeView
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="lDrives"></param>
        public static void SetLocalDrive(TreeView tv)
        {
            DriveInfo[] lDrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in lDrives)
            {
                TreeNode tn = new TreeNode(item.Name);
                tv.Nodes.Add(tn);

                GetSubDir(tn, tn.FullPath);
            }
        }

        /// <summary>
        /// Получение каталогов и добавление их в ListView
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lv"></param>
        public static void GetDirectories(string path, ListView lv)
        {
            try
            {
                lv.Clear();

                string[] dirs = Directory.GetDirectories(path);

                AddListViewItems(dirs, lv, 0);

                string[] files = Directory.GetFiles(path);

                AddListViewItems(files, lv, 1);

            }
            catch (Exception)
            {
                lv.Clear();
            }
        }

        /// <summary>
        /// Заполняет переданный ListView элементами
        /// </summary>
        /// <param name="items"></param>
        /// <param name="lv"></param>
        /// <param name="picture"></param>
        private static void AddListViewItems(string [] items, ListView lv, int picture)
        {
            foreach (string item in items)
            {
                string[] tmp = item.Split(('\\'));

                lv.Items.Add(tmp[tmp.Length - 1], picture);
            }
        }

        /// <summary>
        /// Получение под папок по указанному пути
        /// </summary>
        /// <param name="tn"></param>
        /// <param name=""></param>
        public static void GetSubDir (TreeNode tn, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(tn.FullPath);

                foreach (string item in dirs)
                {
                    string [] tmp = item.Split('\\');

                    TreeNode ntr = new TreeNode(tmp[tmp.Length - 1]);

                    tn.Nodes.Add(ntr);
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Поиск узла по пути и в случае нахождения - выбрать его
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="path"></param>
        public static void SearchNode(TreeView tv, string path)
        {
            TreeNode res = null;

            foreach (TreeNode tn in tv.Nodes)
            {
                Searching(tn.Nodes, path, ref res);

                if (res != null)
                {
                    tv.Focus();
                    tv.SelectedNode = res;
                    
                    return;
                }
            }
        }

        /// <summary>
        /// Функция для поиска в дочерних узлах дерева
        /// </summary>
        /// <param name="tnc"></param>
        /// <param name="path"></param>
        /// <param name="res"></param>
        private static void Searching(TreeNodeCollection tnc, string path, ref TreeNode res)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.FullPath == path)
                {
                    res = tn;
                }

                Searching(tn.Nodes, path, ref res);

            }
        }
    }
}
