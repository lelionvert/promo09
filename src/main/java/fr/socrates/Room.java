package fr.socrates;

public enum Room {
    SINGLE(850),
    DOUBLE(750),
    TRIPLE(650);

    private int price;

    Room(int price) {
        this.price = price;
    }

    public int getPriceWithAllMeals() {
        return price;
    }
}
