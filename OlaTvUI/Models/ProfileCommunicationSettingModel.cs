using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class ProfileCommunicationSettingModel
    {
        public ProfileCommunicationSetting ProfileCommunicationSetting { get; set; }

        public IEnumerable<Profile> Profiles { get; set; }
        public IEnumerable<CommunicationSetting> CommunicationSettings { get; set; }

    }
}
