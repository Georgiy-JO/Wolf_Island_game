using Wolf_Island.Core.Entities.Service;

namespace Wolf_Island.Core.Entities.Objects
{
    internal abstract class Food : Entity
    {
        public uint Value { get; }          // Can be made changeable - that would allow to make animal eat part of food and allow the dissapearing logic to be implemented

        protected readonly uint MaxChangeTimer;
        protected uint _changeTimer;


        public Food(FoodData data, (uint x, uint y) coord = default)
        {
            Value = data.Value;
            Coord = coord;
            MaxChangeTimer = data.ChangeTimer;
            _changeTimer = data.CurChangeTimer;
        }
        public virtual void Update(Game.Data data, List<(uint x, uint y)>? newData) { }
    }

    internal abstract class Grassy : Food
    {
        public Grassy(FoodData data, (uint x, uint y) coord = default) : base(data, coord) { }
    }
    internal abstract class Meaty : Food
    {
        public Meaty(FoodData data, (uint x, uint y) coord = default) : base(data, coord) { }
    }
}