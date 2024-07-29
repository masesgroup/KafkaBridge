#
# Module manifest for module 'MASES.KNetPS'
#
# Generated by: MASES s.r.l.
#

@{

RootModule = 'MASES.KNetPS.psm1'

ModuleVersion = '2.7.6'

CompatiblePSEditions = 'Desktop', 'Core'

GUID = '701745F8-9DD8-4A84-830F-42098FD5FB49'

Author = 'MASES s.r.l.'

CompanyName = 'MASES s.r.l.'

Copyright = 'Copyright ©  MASES s.r.l. 2024'
Description = 'KNet PowerShell command line interface is a PowerShell Module to use Apache Kafka and PowerShell side-by-side. With KNet PowerShell it is possible to:
- execute all tools of Apache Kafka within a PowerShell shell: Administration tools, Console Consumer, Console Producer, manage Apache Kafka Streams, activate Apache Kafka Connect, server side (start Kafka and ZooKeeper), etc
- create consumers and producers objects to interact with an Apache Kafka cluster
- send data to and receive data from an Apache Kafka cluster
- create a Kafka Admin Client object to manage an Apache Kafka cluster

More information within the project hosted on GitHub. Further information at https://github.com/masesgroup/KNet.'

PowerShellVersion = '5.1'

# PowerShellHostName = ''

# PowerShellHostVersion = ''

# DotNetFrameworkVersion = ''

# CLRVersion = ''

# ProcessorArchitecture = ''

# RequiredModules = @()

# RequiredAssemblies = @()

# ScriptsToProcess = @()

# TypesToProcess = @()

# FormatsToProcess = @()

# NestedModules = @()

FunctionsToExport = @()

CmdletsToExport = @(
    'Start-KNetPS',
    'New-KObject',
    'Start-AclCommand',
    'Start-BrokerApiVersionsCommand',
    'Start-ConfigCommand',
    'Start-ConsumerGroupCommand',
    'Start-DelegationTokenCommand',
    'Start-DeleteRecordsCommand',
    'Start-FeatureCommand',
    'Start-LeaderElectionCommand',
    'Start-LogDirsCommand',
    'Start-MetadataQuorumCommand',
    'Start-ReassignPartitionsCommand',
    'Start-TopicCommand',
    'Start-ZkSecurityMigrator',
    'Start-KafkaStart',
    'Start-ZooKeeperShell',
    'Start-ZooKeeperStart',
    'Start-MetadataShell',
    'Start-ClusterTool',
    'Start-ConsoleConsumer',
    'Start-ConsoleProducer',
    'Start-ConsumerPerformance',
    'Start-DumpLogSegments',
    'Start-GetOffsetShell',
    'Start-MirrorMaker',
    'Start-ProducerPerformance',
    'Start-ReplicaVerificationTool',
    'Start-StorageTool',
    'Start-StreamsResetter',
    'Start-TransactionsCommand',
    'Start-VerifiableConsumer',
    'Start-VerifiableProducer',
    'Start-ConnectDistributed',
    'Start-ConnectStandalone',
    'Start-MirrorMaker2',
    'New-AdminClientConfigBuilder',
    'New-ConsumerConfigBuilder',
    'New-KafkaAdminClient',
    'New-KafkaConsumer',
    'New-KafkaProducer',
    'New-KNetConsumer',
    'New-KNetProducer',
    'New-ProducerConfigBuilder',
    'Invoke-Poll',
    'Get-ConsumerRecord',
    'Get-ConsumerGroupMetadata',
    'Invoke-Subscribe',
    'Invoke-Unsubscribe',
    'New-ProducerRecord',
    'Invoke-Send'
)

VariablesToExport = '*'

AliasesToExport = @()

# DscResourcesToExport = @()

# ModuleList = @()

# FileList = @()

PrivateData = @{

    PSData = @{

        Tags = @('KNetPS', 'PSEdition_Core', 'PSEdition_Desktop', 'Windows', 'Linux', 'ZooKeeper', 'Apache', 'Kafka', 'ApacheKafka', 'Admin', 'Consumer', 'Producer')

        LicenseUri = 'https://github.com/masesgroup/KNet/blob/master/LICENSE'

        ProjectUri = 'https://github.com/masesgroup/KNet'

        IconUri = 'https://raw.githubusercontent.com/masesgroup/KNet/master/src/net/Common/JCOB128x128.png'

        ReleaseNotes = 'https://github.com/masesgroup/KNet/releases'

    }

} 

HelpInfoURI = 'https://knet.masesgroup.com/articles/usagePS.html'

# DefaultCommandPrefix = ''
}

