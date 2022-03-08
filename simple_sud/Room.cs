namespace simple_sud
{
    public class Room
    {
        private Room _north;
        private Room _south;
        private Room _east;
        private Room _west;

        public string Description { get; set; } = "";

        public Room GoNorth
        {
            get
            {
                return _north;
            }
        }

        public Room? GoSouth => _south;
        public Room? GoEast => _east;
        public Room? GoWest => _west;

        public void AddToNorth(Room otherRoom)
        {
            otherRoom._south = this;
            _north = otherRoom;
        }
        public void AddToSouth(Room otherRoom)
        {
            otherRoom._north = this;
            _south = this;
        }

        public void AddToEast(Room otherRoom)
        {
            otherRoom._west = this;
            _east = otherRoom;
        }

        public void AddWest(Room otherRoom)
        {
            otherRoom._east = this;
            _west = otherRoom;
        }

    }
}
