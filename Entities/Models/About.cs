﻿namespace Entities.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string? SubTitle { get; set; }
        public string Description { get; set; }
        public string? SubDescription { get; set; }
        public bool? Status { get; set; }
        public bool? IsSub { get; set; }
    }
}
