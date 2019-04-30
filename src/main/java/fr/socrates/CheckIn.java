package fr.socrates;

import java.time.LocalDateTime;
import java.util.Optional;

class CheckIn {

    private final Optional<LocalDateTime> checkInDateTime;

    CheckIn(LocalDateTime checkInDate) {
        this.checkInDateTime = Optional.of(checkInDate);
    }

    CheckIn() {
        this.checkInDateTime = Optional.empty();
    }

    boolean isConsideredLate(LocalDateTime latenessDeadLine) {
        LocalDateTime actualCheckInDateTime = checkInDateTime.orElse(LocalDateTime.MIN);

        return latenessDeadLine.toLocalDate().isEqual(actualCheckInDateTime.toLocalDate())
                && actualCheckInDateTime.isAfter(latenessDeadLine);
    }

    @Override
    public String toString() {
        return "CheckIn{" +
                "checkInDateTime=" + checkInDateTime +
                '}';
    }
}