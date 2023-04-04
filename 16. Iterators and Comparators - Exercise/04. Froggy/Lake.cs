namespace _04._Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    public class Lake : IEnumerable<int>
    {

        private int position;
        public List<int> Stones;
        public Lake(int[] stones)
        {
            Stones = new List<int>(stones);
            this.position = default;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int currentStone = 0; currentStone < this.Stones.Count; currentStone++)
            {
                int current = this.Stones[position];
                if (this.position % 2 == 0)
                    this.position += 2;
                else if (this.position % 2 == 1)
                    this.position -= 2;
                if (this.position == this.Stones.Count)
                    this.position--;
                else if (this.position > this.Stones.Count)
                    this.position -= 3;

                yield return current;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
           => GetEnumerator();
    }
}
