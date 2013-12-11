﻿namespace OJS.Web.Areas.Contests.ViewModels.Results
{
    using System.Collections.Generic;

    public class ContestResultsViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public IEnumerable<ContestProblemViewModel> Problems { get; set; }

        public IEnumerable<ParticipantResultViewModel> Results { get; set; }
    }
}