import java.util.Scanner;

// interface IView {
//     int getValue(String title);

//     void print(int data, String title);
// }

public class View {
    Scanner in = new Scanner(System.in);

    // @Override
    public int getValue(String title) {
        System.out.printf("%s", title);
        return in.nextInt();
    }

    // @Override
    public void print(int data, String title) {
        System.out.printf("%s %d\n", title, data);
    }
}
