
class Node {
    int key;
    Node left, right;
 
    public Node(int item){
        key = item;
        left = right = null;
    }
}

public class BinaryTree{
    
    Node root;

    public BinaryTree(){
        this.root = null;
    }
    
    public void addNode(int num){
        if (this.root == null){
            this.root = new Node(num);
        }else{
            add(num, this.root);
        }
        
    }

    public void printOrder(String order){
        if (order == "in"){
            printInOrder(this.root);
        }
        if (order == "pre"){
            printPreOrder(this.root);
        }
        if (order == "post"){
            printPostOrder(this.root);
        }
    }

    private void add(int num, Node node){

        if (node.key < num){
            if (node.right == null){
                node.right = new Node(num);
                return;
            }else{
                add(num, node.right);
            }
        }
        if (node.key > num){
            if (node.left == null){
                node.left = new Node(num);
                return;
            }else{
                add(num, node.left);
            }
        }
    }

    private static void printInOrder(Node node){

        if(node.left != null){
            printInOrder(node.left);
        }

        System.out.print(node.key);

        if (node.right != null){
            printInOrder(node.right);
        }
    }

    private static void printPreOrder(Node node){
        System.out.print(node.key);
        if (node.left != null){
            printPreOrder(node.left);
        }
        if (node.right != null){
            printPreOrder(node.right);
        }
    }

    private static void printPostOrder(Node node){ 
        if (node.left != null){
            printPostOrder(node.left);
        }
        if (node.right != null){
            printPostOrder(node.right);
        }
        System.out.print(node.key);
    }

    public static void main(String[] args)
    {
        BinaryTree bTree = new BinaryTree();
        int[] nums = {4, 6, 2, 1, 3, 5};

        for (int i = 0; i < nums.length; i++){
            System.out.println("Adding " + nums[i]);
            bTree.addNode(nums[i]);
        }
        
        System.out.println();
        System.out.println("Pre Order:");
        bTree.printOrder("pre");
        System.out.println();
        System.out.println("In Order:");
        bTree.printOrder("in");
        System.out.println();
        System.out.println("Post Order:");
        bTree.printOrder("post");


    }
}

