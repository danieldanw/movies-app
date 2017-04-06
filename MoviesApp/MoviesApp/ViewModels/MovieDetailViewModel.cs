﻿using MoviesApp.Models;

using System.Collections.Generic;
using System.Windows.Input;

namespace MoviesApp.ViewModels
{
    public class MovieDetailViewModel : BaseViewModel
    {
        Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { SetProperty(ref movie, value); }
        }

        public MovieDetailViewModel(Movie movie)
        {
            this.Movie = movie;
        }
    }
}