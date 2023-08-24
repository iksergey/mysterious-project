import CalcMVP.CalcModel;

public class SumModel extends CalcModel {

    public SumModel() {
    }

    // do_it
    @Override
    public int result() {
        return super.x + super.y;
    }

    @Override
    public void setX(int value) {
        super.x = value;
    }

    @Override
    public void setY(int value) {
        super.y = value;
    }
}
