public class MyQueue {

    private Stack<int> inputStack, outputStack;

    public MyQueue() {
        
        inputStack = new Stack<int>();
        outputStack = new Stack<int>();

    }
    
    public void Push(int x) {

        while(outputStack.Count != 0)
            inputStack.Push(outputStack.Pop());

        inputStack.Push(x);
        while(inputStack.Count != 0){
            outputStack.Push(inputStack.Pop());
        }
    }
    
    public int Pop() {
        return outputStack.Pop();
    }
    
    public int Peek() {
        return outputStack.Peek();
    }
    
    public bool Empty() {
        
        if(inputStack.Count == 0 && outputStack.Count == 0)
            return true;        
        
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */