namespace ArrayOrderComparer
{
    public static class Extension
    {
        public static string[] SortWithOrder(this string[] array, int[] order)
        {
            var comparer = new ArrayOrderComparer(array, order);
            Array.Sort(array, comparer);

            return array;
        }
    }
}