using System;
using System.Diagnostics;
using System.Linq;
using TodoList.Models;

namespace TodoList.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any todo items.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var todoItems = new TodoItem[]
            {
            new TodoItem{Name="Lavar louça",IsComplete=true},
            new TodoItem{Name="Passar pano",IsComplete=true},
            new TodoItem{Name="Cozinhar",IsComplete=true},
            new TodoItem{Name="Lavar roupa",IsComplete=false},
            new TodoItem{Name="Estender roupa",IsComplete=false},
            new TodoItem{Name="Trocar roupa de cama",IsComplete=true},
            new TodoItem{Name="Sair com o gato",IsComplete=false}
            };
            foreach (TodoItem t in todoItems)
            {
                context.TodoItems.Add(t);
            }
            context.SaveChanges();

        }
    }
}
