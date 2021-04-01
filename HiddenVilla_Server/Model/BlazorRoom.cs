using System.Collections.Generic;

namespace HiddenVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<BlazorRoomProperty> RoomProperties { get; set; }
    }
}