using System.Windows;
using AutoMapper;
using PoGo.NecroBot.Logic;

namespace Necrui
{
    public partial class App : Application
    {
        public App()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GlobalSettings, GlobalSettingsProxy>());
        }
    }
}
