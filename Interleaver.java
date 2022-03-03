public class Interleaver {

    final public int[] generatedArray;
    final int blockSize;
    final int delay;
    final int spread;

    // Construct Interleaver Block Size = (x * x)
    // Only works on block sizes of powers of 2, need to figure out how to do odd sizes etc
    // Matrix rotation will allow for all sizes to work (obviously not 1)
    public Interleaver(int x) throws Exception {

        if (x == 1) {
            throw new Exception("Cannot interleave a 1x1 matrix.");
        }

        blockSize = x * x;
        delay = blockSize - x;
        spread = x;
        generatedArray = new int[blockSize];
    }

    //buffer[i][j] = curr_pact -> populating the buffer
    //buffer[j][i] -> send the packet

    public int[][] populateArray() {
        int[][] constructedArray = new int[spread][spread];
        int placeholderInt = 1;
        for (int i = 0; i < spread; i++) {
            for (int j = 0; j < spread; j++) {
                constructedArray[i][j] = placeholderInt;
                placeholderInt += 1;
            }
        }

        return constructedArray;
    }

    public void displayArrayInterleaved(int[][] twoDimensionalArray) {
        for (int i = 0; i < spread; i++) {
            for (int j = 0; j < spread; j++) {
                System.out.println(twoDimensionalArray[j][i]);
            }
        }
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
