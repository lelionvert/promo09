package fr.socrates;

import java.time.LocalDateTime;

class Participant {

    private final LocalDateTime checkInDate;

    Participant(LocalDateTime checkInDate) {
        this.checkInDate = checkInDate;
    }

    public LocalDateTime getCheckInDate() {
        return checkInDate;
    }
}