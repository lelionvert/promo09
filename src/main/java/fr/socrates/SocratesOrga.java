package fr.socrates;

import java.time.LocalDateTime;
import java.util.List;

class SocratesOrga {
    static int countColdMeals(List<Participant> participants) {
        LocalDateTime coldMealsStartDateTime = LocalDateTime.of(2019, 4, 18, 21, 0);
        boolean isAfter = participants.stream()
                .filter(participant -> participant.getCheckInDate() != null)
                .anyMatch(participant -> participant.getCheckInDate().isAfter(coldMealsStartDateTime));
        if (!participants.isEmpty() && isAfter) {
            return 1;
        }
        return 0;
    }
}
