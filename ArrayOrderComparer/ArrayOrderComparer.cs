namespace ArrayOrderComparer
{
    public class ArrayOrderComparer : IComparer<string>
    {
        private readonly int[] _desiredOrder;
        private readonly string[] _array;
        public ArrayOrderComparer(string[] array, int[] desiredOrder)
        {
            _array = array;
            _desiredOrder = desiredOrder;
        }

        public int Compare(string a, string b)
        {
            if (_desiredOrder == null)
                return 0;

            if (a == null || b == null)
                return 0;

            var candidateIndexA = Array.FindIndex(_array, row => row == a);
            var desiredIndexA = _desiredOrder.ElementAtOrDefault(candidateIndexA);

            var candidateIndexB = Array.FindIndex(_array, row => row == b);
            var desiredIndexB = _desiredOrder.ElementAtOrDefault(candidateIndexB);

            if (desiredIndexB > desiredIndexA)
                return -1;
            else if (desiredIndexA > desiredIndexB)
                return 1;
            else
                return 0;
        }
    }
}