package fr.socrates;

import java.time.LocalDateTime;

class Registration {
    private static final int MEALS_PRICE = 40;
    private static final int MAX_MEALS = 6;

    private CheckIn checkIn;
    private LocalDateTime socratesDateStart;

    Registration(CheckIn checkIn, LocalDateTime socratesDateStart) {
        this.socratesDateStart = socratesDateStart;
        this.checkIn = checkIn;
    }

    Registration() {
    }

    int calculatePrice(Room room) {
        if (checkIn != null && checkIn.isAfter(socratesDateStart)) {
            return room.getPrice() + (MAX_MEALS - 1) * MEALS_PRICE;
        }
        return room.getPrice() + MAX_MEALS * MEALS_PRICE;
    }
}
