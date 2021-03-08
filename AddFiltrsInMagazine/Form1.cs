using AddFiltrsInMagazine.EfContex;
using AddFiltrsInMagazine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFiltrsInMagazine
{

    public partial class Form1 : Form
    {
        
        private readonly EFContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new EFContext();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.AutoScroll = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;


            Seeder.SeedDatabase(_context);
             var filters = GetFilterNameModels();
             FillCheckedList(filters);
        }

        private IEnumerable<FilterNameModel> GetFilterNameModels()
        {
            List<FilterNameModel> filterNameModels = new List<FilterNameModel>();
            //  Витягуємо елементи FilterName з БД
            var filterNames = from x in this._context.FilterNames.AsQueryable() select x;
            //  Витягуємо елементи FilterNameValue з БД
            var filterNameValue = from x in this._context.FilterNameGroups.AsQueryable() select x;

            var joinedCollection = (from name in filterNames    //  Вибірка усіх елементів FilterName З колекції
                                                                //  Join елементів по Id N-ного елемента і FilterNameId проміжної таблички
                                    join nameValue in filterNameValue on name.Id equals
                                    //  Запис данних у згруповану колекцію oneElementJoinedColl
                                    nameValue.FilterNameId into oneElementJoinedColl
                                    //  Проходження по новій колекції і формування анонімних обєктів
                                    from v in oneElementJoinedColl
                                    select new
                                    {
                                        FilterName = name.Name,
                                        FilterNameId = name.Id,
                                        FilterValue = v.FilterValueOf.Name,
                                        FilterValueId = v.FilterValueId
                                        // Приведення до типу AsEnumerable
                                    }).AsEnumerable();

            //  Вибірка елементів з колекції joinedCollection
            var groupsFilters = from x in joinedCollection
                                    //  Групування данних за ідентифікатором та назвою фільтра і переміщення нової
                                    //  колекції IGrouping до змінної newIGroupingCollection
                                group x by new { x.FilterNameId, x.FilterName } into newIGroupingCollection
                                //  Сортування нової колекції за іменем за спаданням
                                orderby newIGroupingCollection.Key.FilterName descending
                                //  Повернення колекції(груп)
                                select newIGroupingCollection;

            foreach (var item in groupsFilters)
            {
                //  Створення нової моделі де зберігаються дані про фільтр
                //  та його формуються його дочірні елементи
                FilterNameModel model = new FilterNameModel
                {
                    Id = item.Key.FilterNameId,
                    Name = item.Key.FilterName,
                    Children = item.Select(x => new FilterValueModel
                    {
                        Name = x.FilterValue,
                        Id = x.FilterValueId
                    }).ToList()
                };
                //  Додавання до колекції фільтрів нову модель
                filterNameModels.Add(model);
            }



            return filterNameModels;
        }

        private void FillCheckedList(IEnumerable<FilterNameModel> models)
        {
            GroupBox gbFilter;
            CheckedListBox listBox;
            int dy = 13;
            foreach (var item in models)
            {
                gbFilter = new System.Windows.Forms.GroupBox();
                listBox = new System.Windows.Forms.CheckedListBox();
                gbFilter.SuspendLayout();
                // 
                // gbFilter
                // 
                gbFilter.Controls.Add(listBox);
                gbFilter.Location = new System.Drawing.Point(13, dy);
                gbFilter.Name = $"gbFilter{item.Id}";
                gbFilter.Size = new System.Drawing.Size(222, 217);
                gbFilter.TabIndex = 0;
                gbFilter.TabStop = false;
                gbFilter.Text = item.Name;
                gbFilter.ForeColor = Color.Red;
                gbFilter.Tag = item;
                gbFilter.Click += new EventHandler(GbFilter_Click);

                // 
                // listBox
                // 
                listBox.FormattingEnabled = true;
                listBox.Location = new System.Drawing.Point(0, 30);
                listBox.Name = $"listBox{item.Id}";
                listBox.Width = 208;
                listBox.TabIndex = 0;
                foreach (var child in item.Children)
                {
                    listBox.Items.Add(child);
                }

                gbFilter.Size = new Size(listBox.Size.Width, listBox.Size.Height + 30);
                dy += gbFilter.Size.Height + 10;
                this.Controls.Add(gbFilter);

            }
        }

        private void GbFilter_Click(object sender, EventArgs e)
        {
            var groupBox = (sender as GroupBox);
            var FilterName = groupBox.Tag as FilterNameModel;
            if (FilterName.IsCollapsed)
            {
                FilterName.IsCollapsed = false;
            }
            else
            {
                FilterName.IsCollapsed = true;

            }

            var checkedList = groupBox.Controls.OfType<CheckedListBox>().FirstOrDefault();

            checkedList.Visible = FilterName.IsCollapsed;
            var Height = FilterName.IsCollapsed == true ? checkedList.Height + 30 : 30;
            groupBox.Height = Height;

            ShowAllGroups(this.Controls.OfType<GroupBox>());

        }

        private void ShowAllGroups(IEnumerable<GroupBox> groupBoxes)
        {
            int dy = 13;
            foreach (var box in groupBoxes)
            {
                box.Location = new Point(box.Location.X, dy);
                dy += box.Size.Height + 10;
            }
        }




    }
}
