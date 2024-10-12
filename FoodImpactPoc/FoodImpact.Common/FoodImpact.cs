using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodImpact.Common;

public class FoodImpact
{
    [Key]
    [Column("code_agb")]
    [StringLength(7)]
    public string CodeAgb { get; set; }

    [Column("code_ciqual")]
    public int? CodeCiqual { get; set; }

    [Column("groupe_aliment")]
    [StringLength(43)]
    public string GroupeAliment { get; set; }

    [Column("sousgroupe_aliment")]
    [StringLength(49)]
    public string SousgroupeAliment { get; set; }

    [Column("nom_produit_fr")]
    [StringLength(139)]
    public string NomProduitFr { get; set; }

    [Column("lci_name")]
    [StringLength(150)]
    public string LciName { get; set; }

    [Column("code_saison")]
    public int? CodeSaison { get; set; }

    [Column("code_avion")]
    public int? CodeAvion { get; set; }

    [Column("livraison")]
    [StringLength(15)]
    public string Livraison { get; set; }

    [Column("materiau_emballage")]
    [StringLength(19)]
    public string MateriauEmballage { get; set; }

    [Column("preparation")]
    [StringLength(30)]
    public string Preparation { get; set; }

    [Column("dqr")]
    [StringLength(18)]
    public string Dqr { get; set; }

    [Column("score_unique_ef")]
    [StringLength(20)]
    public string ScoreUniqueEf { get; set; }

    [Column("changement_climatique")]
    public decimal? ChangementClimatique { get; set; }

    [Column("appauvrissement_couche_ozone")]
    public decimal? AppauvrissementCoucheOzone { get; set; }

    [Column("rayonnements_ionisants")]
    public decimal? RayonnementsIonisants { get; set; }

    [Column("formation_photochimique_ozone")]
    [StringLength(21)]
    public string FormationPhotochimiqueOzone { get; set; }

    [Column("particules_fines")]
    [StringLength(21)]
    public string ParticulesFines { get; set; }

    [Column("effets_toxicologiques_noncancerogenes")]
    public decimal? EffetsToxicologiquesNoncancerogenes { get; set; }

    [Column("effets_toxicologiques_cancerogenes")]
    public decimal? EffetsToxicologiquesCancerogenes { get; set; }

    [Column("acidification_terrestre_eaux_douces")]
    [StringLength(20)]
    public string AcidificationTerrestreEauxDouces { get; set; }

    [Column("eutrophisation_eaux_douces")]
    [StringLength(22)]
    public string EutrophisationEauxDouces { get; set; }

    [Column("eutrophisation_marine")]
    public decimal? EutrophisationMarine { get; set; }

    [Column("eutrophisation_terrestre")]
    public decimal? EutrophisationTerrestre { get; set; }

    [Column("ecotoxicite_ecosystemes_aquatiques_eau_douce")]
    [StringLength(18)]
    public string EcotoxiciteEcosystemesAquatiquesEauDouce { get; set; }

    [Column("utilisation_sol")]
    [StringLength(17)]
    public string UtilisationSol { get; set; }

    [Column("epuisement_ressources_eau")]
    public decimal? EpuisementRessourcesEau { get; set; }

    [Column("epuisement_ressources_energetiques")]
    [StringLength(17)]
    public string EpuisementRessourcesEnergetiques { get; set; }

    [Column("epuisement_ressources_mineraux")]
    [StringLength(23)]
    public string EpuisementRessourcesMineraux { get; set; }
}