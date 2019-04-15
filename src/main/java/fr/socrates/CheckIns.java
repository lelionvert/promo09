package fr.socrates;

import java.time.LocalDateTime;
import java.util.Arrays;
import java.util.List;

class CheckIns {

    private final List<CheckIn> checkIns;

    CheckIns(CheckIn... checkIns) {
        this.checkIns = Arrays.asList(checkIns);
    }

    long countLateCheckinsForADay(LocalDateTime dateTime) {
        return this.checkIns.stream()
                .filter(checkIn -> checkIn.isConsideredLate(dateTime))
                .count();
    }
}
