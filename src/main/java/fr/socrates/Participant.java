package fr.socrates;

import java.time.LocalDateTime;
import java.util.Optional;

class Participant {

    private final Optional<LocalDateTime> checkInDate;

    Participant(LocalDateTime checkInDate) {
        this.checkInDate = Optional.of(checkInDate);
    }

    Participant() {
        this.checkInDate = Optional.empty();
    }

    Optional<LocalDateTime> getCheckInDate() {
        return checkInDate;
    }
}