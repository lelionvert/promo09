package fr.socrates;

import java.time.LocalDateTime;

class SocratesEvent {
    private LocalDateTime startDateTime;
    private Meal meal;

    SocratesEvent(LocalDateTime startDateTime, Meal meal) {
        this.startDateTime = startDateTime;
        this.meal = meal;
    }

    LocalDateTime getStartDateTime() {
        return startDateTime;
    }

    Meal getMeal() {
        return meal;
    }
}
