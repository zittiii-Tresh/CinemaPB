using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.ModelMovie;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class InsertLanguageForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieRepository _movieRepository;
        private readonly Action _onLanguageInserted;

        public InsertLanguageForm(MovieRepository movieRepository, Action onLanguageInserted)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            _onLanguageInserted = onLanguageInserted;
        }

        private void languagesaveBTN_Click(object sender, EventArgs e)
        {
            var language = new ModelMovie.Language
            {
                LanguageName = languageTE.Text.Trim()
            };

            _movieRepository.InsertLanguage(language);
            _onLanguageInserted?.Invoke(); // 🔁 Trigger the refresh callback

            XtraMessageBox.Show("New language saved successfully!", "Success");
            this.Close();
        }
    }
}