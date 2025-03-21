#
# Module manifest for module 'MASES.KNetPS'
#
# Generated by: MASES s.r.l.
#

@{

# Script module or binary module file associated with this manifest
ModuleToProcess = 'MASES.KNetPS.dll'

# Version number of this module.
ModuleVersion = '2.9.1'

# ID used to uniquely identify this module
GUID = '5E883DB0-584F-4F8E-8D65-2AAB24B491D8'

# Author of this module
Author = 'MASES s.r.l.'

# Company or vendor of this module
CompanyName = 'MASES s.r.l.'

# Copyright statement for this module
Copyright = 'Copyright ©  MASES s.r.l. 2025'

# Description of the functionality provided by this module
Description = 'PowerShell command line interface of .NET suite for Apache Kafka. KNet is a comprehensive .NET suite for Apache Kafka providing all features: Producer, Consumer, Admin, Streams, Connect, backends (ZooKeeper and Kafka).'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Specifies the compatible PSEditions of the module.
CompatiblePSEditions = @('Desktop')

# Name of the Windows PowerShell host required by this module
PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
PowerShellHostVersion = ''

# Minimum version of the .NET Framework required by this module
DotNetFrameworkVersion = '4.6.2'

# Minimum version of the common language runtime (CLR) required by this module
CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64, IA64) required by this module
ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module
ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
#FormatsToProcess = ''

# Modules to import as nested modules of the module specified in ModuleToProcess
NestedModules= @()

# Functions to export from this module
FunctionsToExport = @()

# Cmdlets to export from this module
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

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module
AliasesToExport = @()

# List of all modules packaged with this module
ModuleList = @()

# List of all files packaged with this module
FileList = ''

# Private data to pass to the module specified in ModuleToProcess
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