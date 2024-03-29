﻿using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICommentsService
    {
        IEnumerable<CommentDto> GetAll();
        CommentDto Get(int id);
        void Create(string userId, int postId, string text);
        void Update(CommentDto comment);
        void Delete(int id);
    }
}
