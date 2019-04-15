package fr.socrates;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

class SocratesOrganization {

    private final LocalDateTime coldMealsStartDateTime;

    SocratesOrganization(final LocalDateTime start) {
        this.coldMealsStartDateTime = start;
    }

    long countColdMeals(List<Participant> participants) {
        return participants.stream().map(Participant::getCheckInDate)
                .filter(Optional::isPresent)
                .filter(date -> date.get().isAfter(coldMealsStartDateTime))
                .count();
    }
}
