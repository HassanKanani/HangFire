using HangFireTaturial.Implamation;

namespace HangFireTaturial
{
    public class HangRepo : IHang
    {
        public string delayedinasaddtime()
        {
            return "  انجام وضیفه در چند دقیقه بعد انجام شد";
        }

        public string delayedinsettime()
        {
            return "انجام وضیفه در زمان ست شده انجام شد";
        }

        public string FireAndForget()
        {
            return " انجام شد در زمان اجرا";
        }
    }
}
