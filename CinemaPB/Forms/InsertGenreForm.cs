﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaPB.Configuration;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.ModelMovie;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class InsertGenreForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieRepository _movieRepository;
        private readonly Action _onGenreInserted;
        public InsertGenreForm(MovieRepository movieRepository, Action onGenreInserted)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            _onGenreInserted = onGenreInserted;
        }

        private void genresaveBTN_Click(object sender, EventArgs e)
        {
            var genre = new ModelMovie.Genre
            {
                GenreName = genreTE.Text.Trim()
            };
            _movieRepository.InsertGenre(genre);
            _onGenreInserted?.Invoke(); // ✅ trigger refresh callback

            XtraMessageBox.Show("New genre saved successfully!", "Success");
            this.Close();
        }
    }
}
