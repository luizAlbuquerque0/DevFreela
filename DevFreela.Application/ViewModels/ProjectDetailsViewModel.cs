﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id ,string title, string description, decimal totalCost, DateTime? createdAt, DateTime? finishedAt, string clientFullName,string freelancerFullName)
        {
            Id = id;
            Title = title;
            this.description = description;
            TotalCost = totalCost;
            CreatedAt = createdAt;
            FinishedAt = finishedAt;
            ClientFullName = clientFullName;
            FreelancerFullName = freelancerFullName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public string ClientFullName { get; private set; }
        public string FreelancerFullName { get; private set; }
    }
}
