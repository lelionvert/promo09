package fr.socrates;

import java.time.LocalDateTime;

class Registration {
    private SocratesEvent socratesEvent;
    private Room room;
    private LocalDateTime checkInDateTime;

    Registration(Room room, LocalDateTime checkInDateTime, SocratesEvent socratesEvent) {
        this.room = room;
        this.socratesEvent = socratesEvent;
        this.checkInDateTime = checkInDateTime;
    }

    int calculatePrice() {
        return room.price + calculateTotalMealsPrice();
    }

    private int calculateTotalMealsPrice() {
        int mealsNumber = socratesEvent.getMealNumber();

        if (checkInDateTime.isAfter(socratesEvent.getStartDateTime())) {
            mealsNumber--;
        }
        return this.socratesEvent.calculateTotalPrice(mealsNumber);
    }
}
