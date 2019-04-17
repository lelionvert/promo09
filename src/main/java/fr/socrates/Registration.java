package fr.socrates;

class Registration {
    private static final int MEALS_PRICE = 40;
    private static final int MAX_MEALS = 6;

    int calculatePrice(Room room) {
        return room.getPrice() + MAX_MEALS * MEALS_PRICE;
    }

}
