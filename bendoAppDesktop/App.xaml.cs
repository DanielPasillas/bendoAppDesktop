using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using bendoAppDesktop.DbContextEntities;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace bendoAppDesktop
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        // DbContext Entities
        private static bendo_puntoventaEntities _dbContext;

        public static bendo_puntoventaEntities BendoDbContext { get => App._dbContext; set => App._dbContext = value; }
    }
}
