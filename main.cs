public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        List<int> elements = new List<int>();
        int size = matrix.Length * matrix[0].Length;
        int rowSt = 0, colSt = 0, rowEnd = matrix.Length - 1, colEnd = matrix[0].Length - 1;
        while(elements.Count < size)
        {
            //For starting row addition
            for(int i = colSt; i <= colEnd; i++){
                elements.Add(matrix[rowSt][i]);
            }

            //To add last colm
            for(int i = rowSt + 1; i <= rowEnd; i++){
                elements.Add(matrix[i][colEnd]);
            }
            //To add last row
            if(rowSt != rowEnd){
                for(int i = colEnd - 1; i >= colSt; i--){
                    elements.Add(matrix[rowEnd][i]);
                }
            }
            //To add first colm
            if(colSt != colEnd){
                for(int i = rowEnd - 1; i >= rowSt + 1; i--){
                    elements.Add(matrix[i][colSt]);
                }
            }
            colSt++;
            colEnd--;
            rowSt++;
            rowEnd--;
        }
        return elements; 
    }
}
