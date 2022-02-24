public class Interleaver {

    final public int[] generatedArray;
    final int blockSize;
    final int delay;
    final int spread;

    // Construct Interleaver Block Size = (x * x)
    public Interleaver(int x) throws Exception {

        if (x == 1) {
            //Don't perform interleaving.
        }

        blockSize = x * x;
        delay = blockSize - x;
        spread = x;
        generatedArray = new int[blockSize];
    }

    public int[] generatedInterleavedArray() {
        return new int[1]; //Placeholder
    }

    private int log2(int value) {
        return (int)(Math.log(value) / Math.log(2));
    }

    private boolean isPowerOfTwo(int value) {
        if (value == 0)
            return false;

        return Math.ceil(log2(value)) == Math.floor(log2(value));
    }

    public static void main(String[] args) {
        System.out.println("Interleaver Test Class");
    }
}
