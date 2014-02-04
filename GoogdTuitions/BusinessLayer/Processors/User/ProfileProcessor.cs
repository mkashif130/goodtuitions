using BusinessLayer.Repository.User;
using DataAccessLayer.User;

namespace BusinessLayer.Processors.User
{
    public class ProfileProcessor
    {
        public ProfileEntity GetSingle(string userId)
        {
            var profileRepository = new ProfileRepository();
            return profileRepository.GetSingle(userId);
        }
    }
}
