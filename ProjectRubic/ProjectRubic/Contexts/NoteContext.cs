using Microsoft.EntityFrameworkCore;
using ProjectRubic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRubic.Contexts
{
    public class NoteContext: DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options): base(options)
        { }

        public DbSet<Note> Notes { get; set; }
    }
}
