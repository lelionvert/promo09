package fr.socrates;

public enum Room {
    SINGLE(610),
    DOUBLE(510),
    TRIPLE(410);

    private int price;

    Room(int price) {
        this.price = price;
    }

    public int getPrice() {
        return price;
    }
}
