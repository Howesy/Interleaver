public class Interleaver {

    final public int[] generatedArray;
    final int blockSize;
    final int delay;
    final int spread;

    //Observe the behaviours when swapping.
    
    //Observe 4x4, see if there's a pattern.
    
    // [1, 2, 3, 4, 5, 6, 7, 8, 9] = [1, 4, 7, 2, 5, 8, 3, 6, 9]
    // -> Block size: 3x3, x = 3
    //Swap position array[1] with array[3]
    //Swap position array[2] with array[6]
    //Swap position array[5] with array[8]
    
    
    // [1, 2, 3, 4] = [1, 3, 2, 4] 
    // -> Block size: 2x2, x = 2
    //Swap position array[1] and array[2]
    
    // Construct Interleaver Block Size = (x * x)
    // Only works on block sizes of powers of 2, need to figure out how to do odd sizes etc
    // Matrix rotation will allow for all sizes to work (obviously not 1)
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
