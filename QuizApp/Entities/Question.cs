﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizApp.Entities
{
    public class Question : BaseModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(256)]
        public string Text { get; set; }

        [Required]
        public Answer CorrectAnswer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}