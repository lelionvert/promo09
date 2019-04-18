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

    Registration(Room room, SocratesEvent socratesEvent) {
        this.room = room;
        this.socratesEvent = socratesEvent;
    }

    int calculatePrice() {
        return room.price + calculateTotalMealsPrice();
    }

    private int calculateTotalMealsPrice() {
        int mealsNumber = this.socratesEvent.getMeal().getNumber();

        if (checkIn != null && checkIn.isAfter(socratesEvent.getStartDateTime())) {
            mealsNumber--;
        }
        return this.socratesEvent.getMeal().calculateTotalPrice(mealsNumber);
    }
}
