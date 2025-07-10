using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class Hall1Form : DevExpress.XtraEditors.XtraUserControl
    {
        public Hall1Form()
        {
            InitializeComponent();
            GenerateSeatTiles();
        }
        private void GenerateSeatTiles()
        {
            tileControl1.Groups.Clear();
            tileControl1.Orientation = Orientation.Horizontal;

            DevExpress.XtraEditors.TileGroup seatGroup = new DevExpress.XtraEditors.TileGroup();
            tileControl1.Groups.Add(seatGroup);

            int columns = 10; // A to J
            int rows = 8;     // 1 to 8
            int tileSize = 70;
            int spacing = 4;

            tileControl1.IndentBetweenItems = spacing;
            tileControl1.ItemPadding = new Padding(0);
            tileControl1.Padding = new Padding(0);

            // ✅ Loop COLUMN-first for left-to-right layout
            for (int row = 1; row <= rows; row++)
            {
                for (char col = 'A'; col < 'A' + columns; col++)
                {
                    string seatLabel = $"{col}{row}";

                    DevExpress.XtraEditors.TileItem tile = new DevExpress.XtraEditors.TileItem();
                    tile.ItemSize = TileItemSize.Small;
                    tile.Text = seatLabel;
                    tile.AppearanceItem.Normal.BackColor = Color.LightGreen;
                    tile.AppearanceItem.Normal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    tile.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    tile.AppearanceItem.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    tile.Tag = "Available";

                    tile.ItemClick += (s, e) =>
                    {
                        var clicked = (DevExpress.XtraEditors.TileItem)s;
                        MessageBox.Show($"Seat {clicked.Text} clicked.");
                    };

                    seatGroup.Items.Add(tile);
                }
            }

            tileControl1.Width = (tileSize + spacing) * columns + spacing;
            tileControl1.Height = (tileSize + spacing) * rows + spacing;
        }
    }
}