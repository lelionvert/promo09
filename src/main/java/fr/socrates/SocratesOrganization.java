package fr.socrates;

import java.time.LocalDateTime;
import java.util.Arrays;
import java.util.Optional;

class SocratesOrganization {

    private final LocalDateTime coldMealsStartDateTime;
    private final LocalDateTime coldMealsEndDateTime;

    SocratesOrganization(final LocalDateTime coldMealsStart, final LocalDateTime coldMealsEnd) {
        this.coldMealsStartDateTime = coldMealsStart;
        this.coldMealsEndDateTime = coldMealsEnd;
    }

    long countColdMeals(Participant... participants) {
        return Arrays.stream(participants)
                .map(Participant::getCheckInDate)
                .filter(Optional::isPresent)
                .map(Optional::get)
                .filter(date -> date.isAfter(coldMealsStartDateTime) && date.isBefore(coldMealsEndDateTime))
                .count();
    }
}
