using Services.Interfaces;

namespace Adapters
{
    public class ImageAdapter : IImageAdapter
    {
        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-afghan/n02088094_7146.jpg";
        }
    }
}
