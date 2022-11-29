namespace Task41
{
    public static class ArrayExtention
    {
        public static int[] CopyArray(this int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            return arrayCopy;
        }
    }
}