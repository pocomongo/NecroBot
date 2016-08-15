using PoGo.NecroBot.Logic;
using System.Windows.Controls;

namespace Necrui
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            GlobalSettings = new GlobalSettings();
            GlobalSettingsProxy = new GlobalSettingsProxy(GlobalSettings);
            this.DataContext = GlobalSettingsProxy;

            InitializeComponent();
        }

        public GlobalSettings GlobalSettings { get; set; }
        public GlobalSettingsProxy GlobalSettingsProxy { get; set; }
    }
}
