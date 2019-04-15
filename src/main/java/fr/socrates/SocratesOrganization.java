package fr.socrates;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

class SocratesOrganization {

    private final LocalDateTime coldMealsStartDateTime;
    private final LocalDateTime coldMealsEndDateTime;

    SocratesOrganization(final LocalDateTime coldMealsStart, final LocalDateTime coldMealsEnd) {
        this.coldMealsStartDateTime = coldMealsStart;
        this.coldMealsEndDateTime = coldMealsEnd;
    }

    long countColdMeals(List<Participant> participants) {
        return participants.stream()
                .map(Participant::getCheckInDate)
                .filter(Optional::isPresent)
                .map(Optional::get)
                .filter(date -> date.isAfter(coldMealsStartDateTime) && date.isBefore(coldMealsEndDateTime))
                .count();
    }
}
