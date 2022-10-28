namespace HiddenVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }

        //List of props specific to each BlazorRoom
        public List<BlazorRoomProp> RoomProps { get; set; }
    }
}
