package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class ColdMealsTest {
    private static final LocalDateTime COLD_MEALS_START = LocalDateTime.of(2019, 4, 18, 21, 0);
    private static final LocalDateTime COLD_MEALS_END = LocalDateTime.of(2019, 4, 19, 0, 0);

    @Test
    public void zero_participant_return_zero_cold_meal() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = Collections.emptyList();

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }

    @Test
    public void one_participant_without_checkIn_date_return_zero() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = new ArrayList<>();
        Participant participant = new Participant();

        participants.add(participant);

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }

    @Test
    public void one_participant_after_cold_meals_start_time_return_one() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = new ArrayList<>();
        Participant participant = new Participant(COLD_MEALS_START.plusHours(1));
        participants.add(participant);

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(1);
    }

    @Test
    public void two_participant_after_cold_meals_start_time_return_two() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = new ArrayList<>();
        Participant participant1 = new Participant(COLD_MEALS_START.plusHours(1));
        Participant participant2 = new Participant(COLD_MEALS_START.plusHours(2));
        participants.add(participant1);
        participants.add(participant2);

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(2);
    }

    @Test
    public void one_participant_before_cold_meals_start_time_return_zero() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = new ArrayList<>();
        Participant participant = new Participant(COLD_MEALS_START.minusHours(3));
        participants.add(participant);

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }

    @Test
    public void one_participant_after_the_cold_meals_end_day_return_0() {
        SocratesOrganization socrates = new SocratesOrganization(COLD_MEALS_START, COLD_MEALS_END);
        List<Participant> participants = new ArrayList<>();
        Participant participant = new Participant(COLD_MEALS_START.plusDays(1).plusHours(1));
        participants.add(participant);

        long result = socrates.countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }
}
