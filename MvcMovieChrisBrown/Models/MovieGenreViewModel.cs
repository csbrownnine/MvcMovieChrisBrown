﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovieChrisBrown.Models
{
    public class MovieGenreViewModel
    {
        public PaginatedList<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}
