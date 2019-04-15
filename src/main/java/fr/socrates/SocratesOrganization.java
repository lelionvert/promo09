package fr.socrates;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

class SocratesOrganization {

    private final LocalDateTime coldMealsStartDateTime;
    private final LocalDateTime coldMealsEndDateTime;

    SocratesOrganization(final LocalDateTime start) {
        this.coldMealsStartDateTime = start;
        this.coldMealsEndDateTime = start.plusHours(4);
    }

    SocratesOrganization(final LocalDateTime coldMealsStart, final LocalDateTime coldMealsEnd) {
        this.coldMealsStartDateTime = coldMealsStart;
        this.coldMealsEndDateTime = coldMealsEnd;
    }

    long countColdMeals(List<Participant> participants) {
        if (participants.stream()
                .map(Participant::getCheckInDate)
                .filter(Optional::isPresent)
                .anyMatch(date -> date.get().isAfter(coldMealsEndDateTime))
        ) {
            return 0;

        }
        return participants.stream()
                .map(Participant::getCheckInDate)
                .filter(Optional::isPresent)
                .filter(date -> date.get().isAfter(coldMealsStartDateTime))
                .count();
    }
}
