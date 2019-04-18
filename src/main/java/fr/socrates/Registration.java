package fr.socrates;

class Registration {
    private SocratesEvent socratesEvent;
    private CheckIn checkIn;
    private Room room;

    Registration(Room room, CheckIn checkIn, SocratesEvent socratesEvent) {
        this.room = room;
        this.socratesEvent = socratesEvent;
        this.checkIn = checkIn;
    }

    int calculatePrice() {
        return room.price + calculateTotalMealsPrice();
    }

    private int calculateTotalMealsPrice() {
        int mealsNumber = socratesEvent.getMealNumber();

        if (checkIn.isAfter(socratesEvent.getStartDateTime())) {
            mealsNumber--;
        }
        return this.socratesEvent.calculateTotalPrice(mealsNumber);
    }
}
