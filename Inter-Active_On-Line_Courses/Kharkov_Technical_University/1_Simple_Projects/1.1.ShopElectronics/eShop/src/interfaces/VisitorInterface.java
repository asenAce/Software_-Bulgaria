package interfaces;

/**
 * Created by asen on 11/2/2015.
 */
public interface VisitorInterface {

    void buy(GoodsInterface goods);
    void returnGoods(GoodsInterface goods);
    String getName();


}
